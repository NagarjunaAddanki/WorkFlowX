import React from 'react';
import Jobs  from "./Jobs"; 

const JobsContainer = () => {
    return (
        <div class="jobs-container wfx-container">
            <div class="wfx-container">
                <Jobs />
            </div>
            <div class="wfx-container">
                Jobs Data
            </div>
        </div>
    );
}

export default JobsContainer;