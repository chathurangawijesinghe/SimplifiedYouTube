﻿import React, { Component } from 'react';
import { Container, Row, CardDeck } from 'reactstrap';
import { Video } from './Video';

export class Videos extends Component {
    static displayName = Videos.name;

    constructor(props) {
        super(props);
        this.state = { videos: [], loading: true };
    }

    componentDidMount() {
        this.getAllVideos();
    }

    render() {
        return (
            <div>
                <Container>
                    <Row>
                        <h2>Videos</h2>
                    </Row>
                    {this.state.videos.map((value, index) => {
                        return <Video key={index} data={value} />
                    })}
                </Container>
            </div>
        );
    }

    async getAllVideos() {
        const response = await fetch('http://localhost:9001/api/videos');
        const data = await response.json();
        this.setState({ videos: data.data, loading: false });
    }
}