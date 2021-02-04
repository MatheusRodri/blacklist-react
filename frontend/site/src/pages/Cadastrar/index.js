import React, { useState } from 'react';
import {ToastContainer, toast} from "react-toastify"
import 'react-toastify/dist/ReactToastify.css'
import ListaNegraApi from "../../services/ListaNegraApi"
const api = new ListaNegraApi()


export default function Cadastrar(){
    const [nome, setNome] = useState('')
    const [motivo,setMotivo] = useState('')
    
    const salvarClick = async() =>{
        const resp = await
        api.cadastrar({
            nome:nome,
            motivo:motivo
        })
      toast.success('CADASTRADO NA LISTA NEGRA')
    }

    
    
    return(
        <div>
            <h1>Cadastrar</h1>
            <div>
                <label>Nome:  </label>
                <input onChange={e => setNome(e.target.value)} value={nome} type="text"/>
            </div>
            <div>
            <label>Motivo:  </label>
            <input onChange={e=> setMotivo(e.target.value)} value={motivo} type="text"/>
        </div>
        <div>
            <button onClick={salvarClick}>Cadastrar</button>
        </div>
        <ToastContainer/>

     </div>
    )
}