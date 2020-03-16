import React, { Component } from 'react';
import { Container, Row, Col } from 'reactstrap';
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
                        <Col>
                            {this.state.videos.map((value, index) => {
                                return <Video key={index} data={value} />
                            })}
                        </Col>
                    </Row>
                </Container>
            </div>
        );
    }

    async getAllVideos() {
        const response = await fetch('http://localhost:9001/api/videos');
        const data = await response.json();
        this.setState({ videos: data, loading: false });
    }
}