export async function getAllJobs() {
    try{
        const response = await fetch('https://localhost:7276/data?application=WorkFlowX&operation=jobs_list');
        return await response.json();
    }
    catch(error){
        console.log(`Error - ${error}`)
        return [];
    }
}