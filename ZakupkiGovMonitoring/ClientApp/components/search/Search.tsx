import * as React from 'react';
//import { NavLink, Link } from 'react-router-dom';

export class Search extends React.Component<{}, {}> {
    handleKeyPress() {
    }
    public render() {
        return <div >
            <button type="button" className="btn btn-primary">Поиск</button>
            <div className="search-item">
                <span>Номер/название</span><input onKeyDown={this.handleKeyPress.bind(this)} type="text" name="caption" className="form-control" />
            </div>
            <div className="search-item">
                <span>Дата заключение контракта</span><input onKeyDown={this.handleKeyPress.bind(this)} type="text" name="parchaseStart" className="form-control" />
            </div>
            <div className="search-item">
                <span>Сумма Контракта От</span><input onKeyDown={this.handleKeyPress.bind(this)} type="text" name="contractSumStart" className="form-control" />
            </div>
            <div className="search-item">
                <span>Сумма Контракта До</span><input onKeyDown={this.handleKeyPress.bind(this)} type="text" name="contractSumEnd" className="form-control" />
            </div>
            <div className="search-item">
                <span>Регион заказчикам</span><input onKeyDown={this.handleKeyPress.bind(this)} type="text" name="region" className="form-control" />
            </div>
        </div>;
    }
}
