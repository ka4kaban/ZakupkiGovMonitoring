import * as React from 'react';
import { RouteComponentProps } from 'react-router-dom';
import { connect } from 'react-redux';
import { ApplicationState } from '../../store';
import * as ContractsState from '../../store/Contracts';
import { ContractPreview } from '../contractCommmon/ContractPreview';
import { Search } from '../search/Search';
import { Pagination } from '../pagination';

type ContractsProps =
    ContractsState.ContractsState // ... state we've requested from the Redux store
    & typeof ContractsState.actionCreators      // ... plus action creators we've requested
    & RouteComponentProps<{}>; // ... plus incoming routing parameters

class ContractsList extends React.Component<ContractsProps, {}> {
    componentWillMount() {
        // This method runs when the component is first added to the page
        //let startDateIndex = parseInt(this.props.match.params.startDateIndex) || 0;
        this.props.requestContracts();
    }

    componentWillReceiveProps(nextProps: ContractsProps) {
        // This method runs when incoming props (e.g., route params) change
        //let startDateIndex = parseInt(nextProps.match.params.startDateIndex) || 0;
        this.props.requestContracts();
    }
    private renderContractPreviews() {
        let resArr: any = [];
        if (!this.props.contracts)
            return resArr;
        for (let i = 0; i < this.props.contracts.length; i++) {
            let contract = this.props.contracts[i];
            resArr.push(<ContractPreview key={i} contract={contract} />);
        }
        return resArr;
    }

    public render() {
        return <div>
            <div className='row'>
                <div className='col-sm-3'>
                    <Search />
                </div>
                <div className='col-sm-9'>
                    {this.renderContractPreviews()}
                    <Pagination />
                </div>
            </div>
           
        </div>;
    }
}
export default connect(
    (state: ApplicationState) => state.contracts, // Selects which state properties are merged into the component's props
    ContractsState.actionCreators                 // Selects which action creators are merged into the component's props
)(ContractsList) as typeof ContractsList;
