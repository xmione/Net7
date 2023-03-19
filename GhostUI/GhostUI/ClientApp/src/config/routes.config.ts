import type { ComponentType } from 'react';
import type { Params } from 'react-router-dom';
import { Login, Dashboard, FetchData, Form, Contacts } from '../containers';
import type { IconProp } from '@fortawesome/fontawesome-svg-core';

export const TRANSITION_DEFAULT = {
  classNames: 'fade',
  timeout: { enter: 250, exit: 250 }
};

export type RouteComponent = ComponentType<any>;
export type Transition = typeof TRANSITION_DEFAULT;

export type Route = Readonly<{
  name: string;
  path: string;
  icon?: IconProp;
  showInNav?: boolean;
  transition: Transition;
  Component: RouteComponent;
  params?: Readonly<Params<string>>;
}>;

export const Routes: Route[] = [
  {
    path: '/',
    icon: 'sign-out-alt',
    name: 'Logout',
    Component: Login,
    transition: TRANSITION_DEFAULT
  },
  {
    showInNav: true,
    name: 'Contacts',
    path: '/contacts/:startDateIndex',
    Component: Contacts,
    transition: {
      classNames: 'page-slide-right',
      timeout: { enter: 350, exit: 250 }
    },
    params: {
      startDateIndex: '0'
    }
  },
  {
    path: '/form',
    showInNav: true,
    name: 'Form',
    Component: Form,
    transition: {
      classNames: 'page-slide-left',
      timeout: { enter: 350, exit: 250 }
    }
  },
  {
    showInNav: true,
    path: '/home',
    name: 'Home',
    Component: Dashboard,
    transition: TRANSITION_DEFAULT
  },
  {
    showInNav: true,
    name: 'Fetch',
    path: '/fetch/:startDateIndex',
    Component: FetchData,
    transition: {
      classNames: 'page-slide-right',
      timeout: { enter: 350, exit: 250 }
    },
    params: {
      startDateIndex: '0'
    }
  }
];