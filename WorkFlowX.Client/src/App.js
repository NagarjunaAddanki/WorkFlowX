import logo from './logo.svg';
import './App.css';
import ReactDOM from 'react-dom/client';
import { BrowserRouter, Routes, Route } from 'react-router-dom';
import Jobs from './Components/Jobs';
import NavigationBar from './Components/NavigationBar';

function App() {
  return (
    <div className="app">
      <main className='app-body'>
          <Jobs/>
      </main>
      <footer className='app-footer'>
        <NavigationBar/>
      </footer>
    </div>
  );
}

export default App;
