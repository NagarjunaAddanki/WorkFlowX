export async function getAllJobs() {
    try{
        const response = await fetch('https://localhost:7276/job');
        return await response.json();
    }
    catch(error){
        console.log(`Error - ${error}`)
        return [];
    }
}