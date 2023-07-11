import React from 'react'

function ConfigApplication({name, profile})
{
    return(<h1>Hello {name} - {profile.age}</h1>);   
}

export default ConfigApplication