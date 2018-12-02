import * as React from 'react';
import { RouteComponentProps } from 'react-router-dom';

//purchaseRegNum поле из purchaiseExplanation
export default class Contract extends React.Component<RouteComponentProps<{}>, {}> {
    public render() {

        return <div>

            <button type="button" className="btn btn-primary">Primary</button>
            <button type="button" className="btn btn-secondary">Secondary</button>
            <button type="button" className="btn btn-success">Success</button>
            <button type="button" className="btn btn-danger">Danger</button>
            <button type="button" className="btn btn-warning">Warning</button>
            <button type="button" className="btn btn-info">Info</button>
            <button type="button" className="btn btn-light">Light</button>
            <button type="button" className="btn btn-dark">Dark</button>
            <div>
                <ns2: purchaseRegNum>31300219440</ns2: purchaseRegNum>
                <ns2: purchaseMethodCode>19175</ns2: purchaseMethodCode >
            <ns2: purchaseMethodName>Открытый запрос предложений в электронной форме</ns2: purchaseMethodName >

                Номер контракта: 4770238802718000075 purchaseRegNum
                Сумма контракта: 61 198 300 000 RUB
                Регион: Москва
                Способ размещения заказа: Закупка у единственного поставщика(подрядчика, исполнителя)
                
                Дата заключения контракта: 2018 - 07 - 26
                Дата публикации: 2018 - 11 - 23
                Срок исполнения контракта: -
                    Федеральный закон: 44 - ФЗ
                Ссылка на zakupki.gov.ru:
                Сведения о контракте

                Печатная форма сведений

                Ссылка на.json файл контракта: Перейти
                Количество поставщиков: 2 Показать
                </div>
        </div>;

        //return <div>
        //    <h1>Hello, world!</h1>
        //    <p>Welcome to your new single-page application, built with:</p>
        //    <ul>
        //        <li><a href='https://get.asp.net/'>ASP.NET Core</a> and <a href='https://msdn.microsoft.com/en-us/library/67ef8sbd.aspx'>C#</a> for cross-platform server-side code</li>
        //        <li><a href='https://facebook.github.io/react/'>React</a>, <a href='http://redux.js.org'>Redux</a>, and <a href='http://www.typescriptlang.org/'>TypeScript</a> for client-side code</li>
        //        <li><a href='https://webpack.github.io/'>Webpack</a> for building and bundling client-side resources</li>
        //        <li><a href='http://getbootstrap.com/'>Bootstrap</a> for layout and styling</li>
        //    </ul>
        //    <p>To help you get started, we've also set up:</p>
        //    <ul>
        //        <li><strong>Client-side navigation</strong>. For example, click <em>Counter</em> then <em>Back</em> to return here.</li>
        //        <li><strong>Webpack dev middleware</strong>. In development mode, there's no need to run the <code>webpack</code> build tool. Your client-side resources are dynamically built on demand. Updates are available as soon as you modify any file.</li>
        //        <li><strong>Hot module replacement</strong>. In development mode, you don't even need to reload the page after making most changes. Within seconds of saving changes to files, rebuilt React components will be injected directly into your running application, preserving its live state.</li>
        //        <li><strong>Efficient production builds</strong>. In production mode, development-time features are disabled, and the <code>webpack</code> build tool produces minified static CSS and JavaScript files.</li>
        //        <li><strong>Server-side prerendering</strong>. To optimize startup time, your React application is first rendered on the server. The initial HTML and state is then transferred to the browser, where client-side code picks up where the server left off.</li>
        //    </ul>
        //</div>;
    }
}