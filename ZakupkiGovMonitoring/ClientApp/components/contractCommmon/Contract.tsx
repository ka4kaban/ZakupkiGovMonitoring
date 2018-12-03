import * as React from 'react';
import { RouteComponentProps } from 'react-router-dom';
import { connect } from 'react-redux';
import { ApplicationState } from '../../store';
import * as ContractsState from '../../store/Contracts';
import { ContractPreview } from '../contractCommmon/ContractPreview';


//http://zakupki.gov.ru/epz/contract/contractCard/common-info.html?reestrNumber=0335300036911000008&source=epz
//http://zakupki.gov.ru/223/purchase/public/purchase/info/common-info.html?regNumber=31300690059
//purchaseRegNum поле из purchaiseExplanation

//PurchaseContractData base

type ContractsProps =
    ContractsState.ContractsState // ... state we've requested from the Redux store
    & typeof ContractsState.actionCreators      // ... plus action creators we've requested
    & RouteComponentProps<{}>; // ... plus incoming routing parameters

//class FetchData extends React.Component<WeatherForecastProps, {}> {

//<div className="container">
//    <div className="row">
//        <div className="col-sm">
//            One of three columns
//        </div>
//        <div className="col-sm">
//            One of three columns
//        </div>
//        <div className="col-sm">
//            One of three columns
//        </div>
//    </div>
//</div>

//<div className="form-group">
//    <label htmlFor="exampleInputEmail1">Email address</label>
//    <input type="email" className="form-control" id="exampleInputEmail1" aria-describedby="emailHelp" placeholder="Enter email" />
//    <small id="emailHelp" className="form-text text-muted">We'll never share your email with anyone else.</small>
//</div>
//<div className="form-group">
//    <label htmlFor="exampleInputPassword1">Password</label>
//    <input type="password" className="form-control" id="exampleInputPassword1" placeholder="Password" />
//</div>

//Номер контракта: 4770238802718000075 registrationNumber / purchaseRegNum
//Сумма контракта: 61 198 300 000 RUB currency / sum
//Регион: Москва
//Способ размещения заказа: Закупка у единственного поставщика(подрядчика, исполнителя) Explanation.purchaseMethodName / purchaseMethodCode

//Дата заключения контракта: 2018 - 07 - 26 ContractCreateDate
//Дата публикации: 2018 - 11 - 23 CreateDateTime publicationDateTime
//Срок исполнения контракта: -
//    Федеральный закон: 44 - ФЗ
//Ссылка на zakupki.gov.ru:
//Сведения о контракте

//Печатная форма сведений

//Ссылка на.json файл контракта: Перейти
//Количество поставщиков: 2 Показать

//export default
class Contract extends React.Component<ContractsProps, {}> {
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
            {this.renderContractPreviews()}
            <nav aria-label="Page navigation example">
                <ul className="pagination">
                    <li className="page-item"><a className="page-link" href="#">Previous</a></li>
                    <li className="page-item"><a className="page-link" href="#">1</a></li>
                    <li className="page-item"><a className="page-link" href="#">2</a></li>
                    <li className="page-item"><a className="page-link" href="#">3</a></li>
                    <li className="page-item"><a className="page-link" href="#">Next</a></li>
                </ul>
            </nav>
        </div>;
    }
}
export default connect(
    (state: ApplicationState) => state.contracts, // Selects which state properties are merged into the component's props
    ContractsState.actionCreators                 // Selects which action creators are merged into the component's props
)(Contract) as typeof Contract;
