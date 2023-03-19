﻿import { Provider } from 'react-redux';
import { createRoot } from 'react-dom/client';
import { BrowserRouter } from 'react-router-dom';
import { useEffect, StrictMode, Fragment } from 'react';
import App from './App';
import './assets/style/scss/site.scss';
import { store } from './store';
import { ToastContainer } from 'react-toastify';
import reportWebVitals from './reportWebVitals';
import { SignalRApi } from './api/signalr.service';
import { toastifyProps, registerIcons } from './config';
import * as serviceWorkerRegistration from './serviceWorkerRegistration';
import { InMemoryCache, ApolloClient, ApolloProvider } from '@apollo/client';

registerIcons();

const container = document.getElementById('root');
const root = createRoot(container as HTMLElement);
const client = new ApolloClient({
    //uri: 'https://flyby-gateway.herokuapp.com/',
    uri: 'https://api.thegraph.com/subgraphs/name/graphprotocol/graph-network-mainnet',
    cache: new InMemoryCache(),
});

function AppRenderer() {
  useEffect(() => {
    setTimeout(() => {
      SignalRApi.startConnection();
    }, 250);
  }, []);

  return (
    <Fragment>
      <BrowserRouter>
        <Provider store={store}>
          <StrictMode>
            <ApolloProvider client={client}>
                <App />
            </ApolloProvider>,
          </StrictMode>
        </Provider>
      </BrowserRouter>
      <ToastContainer {...toastifyProps} />
    </Fragment>
  );
}

root.render(<AppRenderer />);

// If you want your app to work offline and load faster, you can change
// unregister() to register() below. Note this comes with some pitfalls.
// Learn more about service workers: https://cra.link/PWA
serviceWorkerRegistration.unregister();

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();
