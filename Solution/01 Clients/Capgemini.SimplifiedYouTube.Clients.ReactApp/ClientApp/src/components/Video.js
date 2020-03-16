import React, { Component } from 'react';

export class Video extends Component {
    static displayName = Video.name;

    render() {
        return (
            <div>
                <video width="320" height="240" controls>
                    <source src="sample1.mp4" type="video/mp4" />
                </video>
                <h1>{this.props.data.name}</h1>

                <p>{this.props.data.description}</p>
            </div>
        );
    }
}
