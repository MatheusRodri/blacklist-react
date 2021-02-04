import React, { useRef, useState } from 'react';
import ListaNegraApi from '../../services/ListaNegraApi'

import LoadingBar from 'react-top-loading-bar';

const api = new ListaNegraApi();

export default function Consultar(){
    const loadingBar = useRef(null);
    const[registro, setRegistro] = useState([])

    const consultarClick = async() =>{
        loadingBar.current.continuousStart();
          
       const lns = await api.consultar()
       setRegistro([...lns])
        loadingBar.current.complete()
    }
    return(
        <div>
            <LoadingBar
                height={5}
                color="red"
                ref={loadingBar}
                />
            <h1>Consultar</h1>
            <div>
                <button onClick={consultarClick}>Consultar</button>
            </div>
            <div>
                <table border="1">
                    <thead>
                        <tr>
                            <th>ID</th>
                            <th>Nome</th>
                            <th>Motivo</th>
                            <th>Data</th>
                        </tr>
                    </thead>
                    <tbody>
                       {registro.map(item => 
                        <tr key={item.id}>
                            <td>#{item.id}</td>
                            <td>{item.nome}</td>
                            <td>{item.motivo}</td>
                            <td>{new Date(item.inclusao + "Z").toLocaleString()}</td>
                        </tr>
                        )}
                    </tbody>
                </table>
            </div>
        </div>
    )
}