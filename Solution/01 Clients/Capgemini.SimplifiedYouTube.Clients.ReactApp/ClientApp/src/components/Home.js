import React, { Component } from 'react';

export class Home extends Component {
    static displayName = Home.name;

    render() {
        return (
            <div>
                <h1>Welcome to Simplified YouTube</h1>
                <p>Software Architecture</p>
                <ul>
                    <li><a href='https://get.asp.net/'>ASP.NET Core</a> and <a href='https://msdn.microsoft.com/en-us/library/67ef8sbd.aspx'>C#</a> for cross-platform server-side code</li>
                    <li><a href='https://facebook.github.io/react/'>React</a> for client-side code</li>
                    <li><a href='http://getbootstrap.com/'>Bootstrap</a> for layout and styling</li>
                    <li><a href='https://grpc.io/'>gRPC</a></li>
                    <li><a href='https://microservices.io/'>Microservices</a></li>
                    <li><a href='https://docs.microsoft.com/en-us/ef/core/'>Entity Framework Core</a></li>
                    <li><a href='https://fluentvalidation.net/'>FLUENT VALIDATION</a></li>
                    <li><a href='https://github.com/jbogard/MediatR'>MediatR</a></li>
                    <li><a href='https://automapper.org/'>Automapper</a></li>
                    <li><a href='https://swagger.io/'>Swagger</a></li>
                    <li><a href='https://docs.microsoft.com/en-us/sql/ssdt/how-to-create-a-new-database-project?view=sql-server-ver15'>SQL Server Database Project</a></li>
                    
                    <li>Tire Architecture</li>
                </ul>
                <p>How to setup</p>
                <ul>
                    <li>Publish Capgemini.SimplifiedYouTube.Databases.Videos Sql Server Database Project to a Empty database</li>
                    <li>Change the "VideoDatabaseConnection" connection string accordingly</li>
                    <li>Run Capgemini.SimplifiedYouTube.Clients.ReactApp, Capgemini.SimplifiedYouTube.APIs.Videos & Capgemini.SimplifiedYouTube.gRPCService.Videos projects</li>
                </ul>
            </div>
        );
    }
}
