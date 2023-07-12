import React from 'react';
import JobCard  from "./JobCard"; 
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
            <div class="d-flex flex-column gap-3">
              {jobs.map(item => (
                <JobCard job={item}/>
              ))}
            </div>
          );
        }
      }
}

export default Jobs;