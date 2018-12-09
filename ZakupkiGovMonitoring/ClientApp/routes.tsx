import * as React from 'react';
import { Route } from 'react-router-dom';
import { Layout } from './components/Layout';
//import Home from './components/Home';
//import FetchData from './components/FetchData';
//import Counter from './components/Counter';
import ContractsList from './components/contractCommmon/ContractsList';
import Contract from './components/contractCommmon/Contract';


export const routes = <Layout>
    <Route exact path='/' component={ContractsList} />
    <Route path='/contract/:id?' component={Contract} />
</Layout>;
//export const routes = <Layout>
//    <Route exact path='/' component={ Home } />
//    <Route path='/counter' component={ Counter } />
//    <Route path='/fetchdata/:startDateIndex?' component={FetchData} />
//    <Route path='/contractsList' component={ContractsList} />
//</Layout>;
