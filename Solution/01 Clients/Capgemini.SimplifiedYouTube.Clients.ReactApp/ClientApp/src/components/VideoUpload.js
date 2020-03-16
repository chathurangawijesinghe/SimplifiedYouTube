import React, { Component } from 'react';
import { Container, Row, Col } from 'reactstrap';

export class VideoUpload extends Component {
    static displayName = VideoUpload.name;

    constructor(props) {
        super(props);
        this.state = {
            file: null
        }
        this.onFormSubmit = this.onFormSubmit.bind(this)
        this.onChange = this.onChange.bind(this)
        this.fileUpload = this.fileUpload.bind(this)
    }
    onFormSubmit(e) {
        e.preventDefault() // Stop form submit
        this.fileUpload(this.state.file).then((response) => {
            console.log(response.data);
        })
    }
    onChange(e) {
        this.setState({ file: e.target.files[0] })
    }
    fileUpload(file) {
        const formData = new FormData();
        const fileField = document.querySelector('input[type="file"]');

        formData.append('avatar', fileField.files[0]);

        fetch('http://localhost:9001/api/videos', {
            method: 'POST',
            body: formData
        })
            .then((response) => response.json())
            .then((result) => {
                console.log('Success:', result);
            })
            .catch((error) => {
                console.error('Error:', error);
            });
    }

    render() {
        return (
            <Container>
                <Row>
                    <h2>Video Upload</h2>
                </Row>
                <form onSubmit={this.onFormSubmit}>
                    <Row>
                        <Col lg={2}>
                            <label>Video Name</label>
                        </Col>
                        <Col lg={4}>
                            <input type="text" />
                        </Col>
                    </Row>
                    <Row>
                        <Col lg={2}>
                            <label>Video Description</label>
                        </Col>
                        <Col lg={4}>
                            <input type="text" />
                        </Col>
                    </Row>
                    <Row>
                        <Col lg={6}>
                            <input type="file" onChange={this.onChange} />
                        </Col>
                    </Row>
                    <Row>
                        <Col lg={2}>
                        </Col>
                        <Col lg={4}>
                            <button variant="primary" type="submit">Upload</button>
                        </Col>
                    </Row>
                </form>
            </Container>
        );
    }
}
