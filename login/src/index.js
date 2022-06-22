import React from 'react';
import './index.css';


import Home from "./Home"
import { createRoot } from 'react-dom/client';
const container = document.getElementById('root');
const root = createRoot(container);           // createRoot(container!) if you use TypeScript
root.render(<Home tab="home" />);

//ReactDOM.render(<Home />, document.getElementById("root"));
/*
const root = ReactDOM.createRoot(document.getElementById('root'));
root.render(
  <React.StrictMode>
  <h1>cia</h1>
  <FormPropsTextFields />

  </React.StrictMode>
);

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();
*/