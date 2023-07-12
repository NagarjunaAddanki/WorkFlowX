import logo from './logo.svg';
import './App.css';
import ReactDOM from 'react-dom/client';
import { BrowserRouter, Routes, Route } from 'react-router-dom';
import JobsContainer from './Components/JobsContainer';
import NavigationBar from './Components/NavigationBar';

function App() {
  return (
    <div className="app">
      <main className='app-body'>
          <JobsContainer/>
      </main>
      <footer className='app-footer'>
        <NavigationBar/>
      </footer>
    </div>
  );
}

export default App;
