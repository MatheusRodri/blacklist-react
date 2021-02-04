import React from 'react';
import { BrowserRouter, Route, Switch } from 'react-router-dom';

import App from './pages/App'
import Cadastrar from './pages/Cadastrar'
import Consultar from './pages/Consultar'


export default function Routes(){
    return(
        <BrowserRouter>
            <Switch>
                <Route path="/" exact={true} component={App}/>
                <Route path="/cadastrar" exact={true} component={Cadastrar}/>
                <Route path="/consultar" exact={true} component={Consultar}/>
            </Switch>
        </BrowserRouter>
    )
}