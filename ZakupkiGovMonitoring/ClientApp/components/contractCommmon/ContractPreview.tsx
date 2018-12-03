import * as React from 'react';
import { RouteComponentProps } from 'react-router-dom';
import { connect } from 'react-redux';
import { ApplicationState } from '../../store';
import * as ContractsState from '../../store/Contracts';
import { Contract } from '../../store/Contracts';

export class ContractPreview extends React.Component<{ contract: Contract }, {}> {
    public render() {
        var zakUrl = 'http://www.zakupki.gov.ru/epz/purchaseplanfz44/purchasePlanStructuredCard/general-info.html?plan-number=' + this.props.contract.registrationNumber;
        return <div className="registerBox registerBoxBank margBtm20">
            <div className="boxIcons displayNonePoor">
                <a href="/epz/purchaseplanfz44/signview/list.html?printFormId=19982602" className="cryptoSignLink linkPopUp ezp pWidth_840" title="Электронная подпись"></a>
                <a href="/epz/purchaseplanfz44/printForm/view.html?printFormId=19982602" className="printLink floatLeft" target="_blank" title="Печатная форма"></a>
            </div>
            <table >
                <tbody><tr>
                    <td className="tenderTd">
                        <dl>
                            <dt className="status-field"><span className="status-icon status-deployed"></span>
                                Размещено: {this.props.contract.createDateTime}
                            </dt>
                            <dd className="greyText padLeft0">Структурированный</dd>
                        </dl>
                    </td>
                    <td className="descriptTenderTd">
                        <dl>
                            <dt>
                                <a target="_blank" href={zakUrl} >№ {this.props.contract.registrationNumber} </a>
                            </dt>
                            <dd className="padBtm5">
                                <a className="uppercaseNone grayText" target="_blank" href="/epz/organization/view/info.html?organizationCode=03572000119" title={this.props.contract.name}>
                                    {this.props.contract.name}
                                </a>
                            </dd>

                            <dd className="margTop5 greyText">
                                <ul>
                                    <li>Финансовый год плана закупок: <span className="baseColor">2018</span>
                                    </li>
                                </ul>
                            </dd>

                            <dd className="greyText">
                                <ul>
                                    <li>Плановый период плана закупок: <span className="baseColor">2019</span> - <span className="baseColor">2020</span> года
                                        </li>
                                </ul>
                            </dd>
                        </dl>
                    </td>
                    <td className="amountTenderTd">
                        <ul>
                            <li><label>Сумма контракта:</label>{this.props.contract.sum}</li>
                        </ul>
                    </td>
                </tr>

                </tbody></table>
            <div className="reportBox">
                <ul>
                    <li>
                        <a href="/epz/purchaseplanfz44/purchasePlanStructuredCard/general-info.html?plan-number=201803572000119001" target="_blank">Сведения</a>
                    </li>
                    <li>
                        <a href="/epz/purchaseplanfz44/purchasePlanStructuredCard/documents-info.html?plan-number=201803572000119001" target="_blank">Документы</a>
                    </li>

                    <li className="displayNoneUsual">
                        <a href="/epz/purchaseplanfz44/signview/list.html?printFormId=19982602" className="cryptoSignLink linkPopUp ezp pWidth_840" title="Электронная подпись"></a>
                    </li>
                    <li className="displayNoneUsual">
                        <a href="/epz/purchaseplanfz44/printForm/view.html?printFormId=19982602" className="printLink" target="_blank" title="Печатная форма"></a>
                    </li>
                </ul>
            </div>
        </div>
    }
}