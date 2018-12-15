import FormControl from '@material-ui/core/FormControl';
import InputLabel from '@material-ui/core/InputLabel';
import MenuItem from '@material-ui/core/MenuItem';
import Paper from '@material-ui/core/Paper';
import Select from '@material-ui/core/Select';
import TextField from '@material-ui/core/TextField';
import React from 'react';


export default class ContractsSearch extends React.Component {
    constructor(props) {
        super(props);
        this.state = {
            purchaseNumber:0,
            budget: 0,
            sumStart: 0,
            sumEnd: 0
        }
    }
    handleChange(val) {
    }
    render() {
        return (<Paper className="root">
            <div className="row">
                <div className="col-md-3">
                    <TextField
                        id="standard-purchaseNumber-flexible"
                        label="Номер контракта"
                        multiline
                        rowsMax="4"
                        value={this.state.purchaseNumber}
                        onChange={this.handleChange('multiline')}
                        className="textField"
                        margin="normal"
                    />
                </div>
                <div className="col-md-3">
                    <form className="container" noValidate>
                        <TextField
                            id="date"
                            label="Дата заключения контракта"
                            type="date"
                            defaultValue="2017-05-24"
                            className="textField"
                            InputLabelProps={{
                                shrink: true,
                            }}
                        />
                    </form>
                </div>
                <div className="col-md-3">
                    <TextField
                        id="sumStart"
                        label="Сумма контракта от"
                        className="textField"
                        value={this.state.sumStart}
                        onChange={this.handleChange('name')}
                        margin="normal"
                    />
                </div>
                <div className="col-md-3">
                    <TextField
                        id="sumEnd"
                        label="Сумма контракта до"
                        className="textField"
                        value={this.state.sumEnd}
                        onChange={this.handleChange('name')}
                        margin="normal"
                    />
                </div>
            </div>
            <div className="row">
                <div className="col-md-3">
                    <FormControl className="formControl">
                        <InputLabel htmlFor="region-simple">Регион госзаказчика</InputLabel>
                        <Select
                            value={this.state.region}
                            onChange={this.handleChange}
                            inputProps={{
                                name: 'region',
                                id: 'region-simple',
                            }}
                        >
                            <MenuItem value="">
                                <em>Россия</em>
                            </MenuItem>
                            <MenuItem value={1}>Тула</MenuItem>
                            <MenuItem value={2}>Москва</MenuItem>
                            <MenuItem value={3}>Питер</MenuItem>
                        </Select>
                    </FormControl>
                </div>
                <div className="col-md-3">
                    <FormControl className="formControl">
                        <InputLabel htmlFor="age-simple">Age</InputLabel>
                        <Select
                            value={this.state.budget}
                            onChange={this.handleChange}
                            inputProps={{
                                name: 'budget',
                                id: 'budget-simple',
                            }}
                        >
                            <MenuItem value="">
                                <em>None</em>
                            </MenuItem>
                            <MenuItem value={1}>федеральный бюджет</MenuItem>
                            <MenuItem value={2}>Бюджет субъекта Российской Федерации</MenuItem>
                            <MenuItem value={3}>местный бюджет</MenuItem>
                            <MenuItem value={4}>бюджет Пенсионного фонда Российской Федерации</MenuItem>
                            <MenuItem value={5}>бюджет Федерального фонда обязательного медицинского страхования</MenuItem>
                            <MenuItem value={6}>бюджет Фонда социального страхования Российской Федерации</MenuItem>
                            <MenuItem value={7}>бюджет территориального государственного внебюджетного фонда</MenuItem>
                        </Select>
                    </FormControl>
                </div>
                <div className="col-md-3">

                    Сортировать
                         
                </div>
                <div className="col-md-3">
                    Адрес:
                ИНН заказчика
                КПП заказчика
                ИНН поставщика
                КПП поставщика
                </div>
            </div>
        </Paper>);
    }

};