import React, { Component } from 'react';
import { Card, Button, CardTitle, CardText, CardSubtitle, CardBody } from 'reactstrap';

const CardStyle = {
    width: '320px',
    display: 'inline-block',
    margin: '0 20px 20px 0'
}

export class Video extends Component {
    static displayName = Video.name;

    render() {
        return (
            <Card style={CardStyle}>
                    <video width="320" height="240" controls>
                        <source src="sample1.mp4" type="video/mp4" />
                    </video>
                    <CardBody>
                        <CardTitle>{this.props.data.name}</CardTitle>
                        <CardText>{this.props.data.description}</CardText>
                    </CardBody>
                </Card>
        );
    }
}
