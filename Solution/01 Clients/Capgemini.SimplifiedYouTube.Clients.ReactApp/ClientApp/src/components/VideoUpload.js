import React, { Component } from 'react';
import { Container, Row, Col } from 'reactstrap';

export class VideoUpload extends Component {
    static displayName = VideoUpload.name;

    render() {
        return (
            <Container>
                <Row>
                    <h2>Video Upload</h2>
                </Row>
                <Row>
                    <input type="file" id="myFile" />
                </Row>
                <Row>
                    <Col>
                        <label>Video Name</label>
                    </Col>
                    <Col>
                        <input type="text" />
                    </Col>
                </Row>
                <Row>
                    <Col>
                        <label>Video Description</label>
                    </Col>
                    <Col>
                        <input type="text" />
                    </Col>
                </Row>
            </Container>
        );
    }
}
