import { fetch, addTask } from 'domain-task';
import { Action, Reducer, ActionCreator } from 'redux';
import { AppThunkAction } from './';

// -----------------
// STATE - This defines the type of data maintained in the Redux store.

export interface ContractsState {
    isLoading: boolean;
    //startDateIndex?: number;
    contracts: Contract[];
}

//export interface Contract {
//    dateFormatted: string;
//    temperatureC: number;
//    temperatureF: number;
//    summary: string;
//}
export interface Contract {
    id: string;
    registrationNumber: string;
    createDateTime: string;
    name: string;
}
//export interface Contract {
//    Id: string;
//    RegistrationNumber: string;
//    CreateDateTime: string;
//    Name: string;
//}
//public class PurchaseContractData {
//    public int Id { get; set; }
//        public string Guid { get; set; }
//        public string RegistrationNumber { get; set; }
//        public string UrlOOS { get; set; }
//        public string CreateDateTime { get; set; }
//        public string ContractCreateDate { get; set; }
//        public Lot Lot { get; set; }
//        public Currency Currency { get; set; }
//        public string Sum { get; set; }
//        public string FulfillmentDate { get; set; }
//        public PurchaseInfo PurchaseInfo { get; set; }
//        public Placer Placer { get; set; }
//        public CustomerInfo CustomerInfo { get; set; }
//        public Supplier Supplier { get; set; }
//        public DeliveryPlace DeliveryPlace { get; set; }
//        public string DeliveryPlaceIndication { get; set; }
//        public ContractItems ContractItems { get; set; }
//        public string Type { get; set; }
//        public string Name { get; set; }
//        public string PublicationDateTime { get; set; }
//        public string Status { get; set; }
//        public string Version { get; set; }
//        public string Attachments { get; set; }
//    }



// -----------------
// ACTIONS - These are serializable (hence replayable) descriptions of state transitions.
// They do not themselves have any side-effects; they just describe something that is going to happen.

interface RequestContractsAction {
    type: 'REQUEST_CONTRACTS';
    //startDateIndex: number;
}

interface ReceiveContractsAction {
    type: 'RECEIVE_CONTRACTS';
    //startDateIndex: number;
    contracts: Contract[];
    //forecasts: WeatherForecast[];
}

// Declare a 'discriminated union' type. This guarantees that all references to 'type' properties contain one of the
// declared type strings (and not any other arbitrary string).
type KnownAction = RequestContractsAction | ReceiveContractsAction;

// ----------------
// ACTION CREATORS - These are functions exposed to UI components that will trigger a state transition.
// They don't directly mutate state, but they can have external side-effects (such as loading data).

export const actionCreators = {
    requestContracts: (): AppThunkAction<KnownAction> => (dispatch, getState) => {
        // Only load data if it's something we don't already have (and are not already loading)
        //if (startDateIndex !== getState().weatherForecasts.startDateIndex) {
        //debugger
        //let fetchTask = fetch(`api/PurchaseContractDatas/GetPurchaseContractData`)
        let fetchTask = fetch(`api/PurchaseContractDatas`)
            .then(response => response.json() as Promise<Contract[]>)
            .then(data => {
                //debugger;
                dispatch({ type: 'RECEIVE_CONTRACTS', contracts: data });
            });

        addTask(fetchTask); // Ensure server-side prerendering waits for this to complete
        dispatch({ type: 'REQUEST_CONTRACTS' });
        //}
    }
};

// ----------------
// REDUCER - For a given state and action, returns the new state. To support time travel, this must not mutate the old state.

const unloadedState: ContractsState = { contracts: [], isLoading: false };

export const reducer: Reducer<ContractsState> = (state: ContractsState, incomingAction: Action) => {
    const action = incomingAction as KnownAction;
    switch (action.type) {
        case 'REQUEST_CONTRACTS':
            return {
                //startDateIndex: action.startDateIndex,
                contracts: state.contracts,
                isLoading: true
            };
        case 'RECEIVE_CONTRACTS':
            // Only accept the incoming data if it matches the most recent request. This ensures we correctly
            // handle out-of-order responses.
            //if (action.startDateIndex === state.startDateIndex) {
            return {
                //startDateIndex: action.startDateIndex,
                contracts: action.contracts,
                isLoading: false
            };
        //}
        //break;
        default:
            // The following line guarantees that every action in the KnownAction union has been covered by a case above
            const exhaustiveCheck: never = action;
    }

    return state || unloadedState;
};
