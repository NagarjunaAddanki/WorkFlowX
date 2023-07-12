import React from 'react';

const JobCard = ({ job }) => {
    return (
        <div class="card">
            <div class="card-header">{job.jobNumber}</div>
            <div class="card-body">
                <p class="card-text">{ job.description}</p>
            </div>
        </div>
    );
}

export default JobCard;