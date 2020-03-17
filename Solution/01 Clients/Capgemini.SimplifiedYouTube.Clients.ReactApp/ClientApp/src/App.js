import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { Videos } from './components/Videos';

import './custom.css'
import { VideoUpload } from './components/VideoUpload';



export default class App extends Component {
    static displayName = App.name;

    render() {
        return (
            <Layout>
                <Route exact path='/' component={Home} />
                <Route path='/videos' component={Videos} />
                <Route path='/video-upload' component={VideoUpload} />
            </Layout>
        );
    }
}
