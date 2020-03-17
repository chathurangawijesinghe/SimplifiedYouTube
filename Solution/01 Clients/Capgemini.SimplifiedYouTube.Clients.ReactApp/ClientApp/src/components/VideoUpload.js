import React, { Component } from 'react';
import { Container, Row, Col, Input, Button, Form, FormGroup } from 'reactstrap';

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
                <Col lg={6}>
                    <h3>Video Upload</h3>
                    <Form onSubmit={this.onFormSubmit}>
                        <FormGroup>
                                <label>Video Name</label>
                            <Input type="text" />
                        </FormGroup>
                        <FormGroup>
                            <label>Video Description</label>
                            <Input type="text" />
                        </FormGroup>
                        <FormGroup>
                            <Input type="file" onChange={this.onChange} />
                        </FormGroup>
                        <FormGroup>
                            <Button color="primary" type="submit">Upload</Button>
                        </FormGroup>
                    </Form>
                </Col>
            </Container>
        );
    }
}
