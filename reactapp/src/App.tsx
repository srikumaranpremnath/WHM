import './App.css';
import WHMRoutes from './Components/Router';
import Navbar from './Components/Navbar';

function App() {
  return (
    <div className="App">
      <Navbar/>
      <WHMRoutes></WHMRoutes>
    </div>
  );
}

export default App;
