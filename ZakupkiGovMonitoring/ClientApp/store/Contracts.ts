import { fetch, addTask } from 'domain-task';
import { Action, Reducer, ActionCreator } from 'redux';
import { AppThunkAction } from './';

// -----------------
// STATE - This defines the type of data maintained in the Redux store.

export interface ContractsState {
    isLoading: boolean;
    contracts: Contract[];
}

export interface Contract {
    contractCreateDate: string;
    createDateTime: string;
    fulfillmentDate: string;
    guid: string;
    id: number;
    name: string;
    publicationDateTime: string;
    registrationNumber: string;
    status: string;
    sum: string;
    type: string;
    urlOOS: string;
    version: string;
}
//export interface Contract {
//    id: string;
//    registrationNumber: string;
//    createDateTime: string;
//    name: string;
//}

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
