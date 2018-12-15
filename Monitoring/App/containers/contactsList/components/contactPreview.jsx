import React from 'react';
import ReactDOM from 'react-dom';

export default class ContactPreview extends React.Component {

    render() {
        return (
            <div>
                name:{this.props.data.name}
                sum:{this.props.data.sum}
                contractCreateDate:{this.props.data.contractCreateDate}
                registrationNumber:{this.props.data.registrationNumber}
            </div>
        );
    }
};