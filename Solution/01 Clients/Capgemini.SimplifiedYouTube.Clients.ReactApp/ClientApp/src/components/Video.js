import React, { Component } from 'react';

export class Video extends Component {
    static displayName = Video.name;

    render() {
        return (
            <div>
                <hr />
                <video width="320" height="240" controls>
                    <source src="sample1.mp4" type="video/mp4" />
                </video>
                <h6>{this.props.data.name}</h6>

                <p>{this.props.data.description}</p>
            </div>
        );
    }
}
