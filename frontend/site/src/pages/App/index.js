
import { Link } from 'react-router-dom';
import './App.css';

function App() {
  return (
    <div className="App">
      <header className="App-header">
       <h1>Lista negra Cadastrar</h1>
       <div>
         <h2><Link to="/cadastrar">Cadastrar</Link></h2>
         <h2><Link to="/consultar">Consultar</Link></h2>
       </div>
      </header>
    </div>
  );
}

export default App;
