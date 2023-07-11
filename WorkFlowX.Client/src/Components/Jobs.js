import React from 'react';
import { getAllJobs } from "../Services/JobService"; 

class Jobs extends React.Component {

    constructor(props){
        super(props);
        this.state = {
            error: null,
            isLoaded: false,
            jobs:[]
        }
    }

    async componentDidMount() {
        let data = await getAllJobs();
        this.setState({
            isLoaded: true,
            jobs: data
        })
        console.log(data);
    }

    render() {
        const { error, isLoaded, jobs } = this.state;
        if (error) {
          return <div>Error: {error.message}</div>;
        } else if (!isLoaded) {
          return <div>Loading...</div>;
        } else {
          return (
            <ul>
              {jobs.map(item => (
                <li key={item.id}>
                  {item.description}
                </li>
              ))}
            </ul>
          );
        }
      }
}

export default Jobs;