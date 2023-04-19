import BackConstants from '../pathConstants/backendConstants';

const endpointService = {
    rideHistoryGET: async () => {
        let resp;
        await fetch(BackConstants.API_URL_RIDE_HISTORY, {
            method: 'GET',
            mode: 'cors',
            credentials: 'include'
        })
            .then((response) => (response = response.json()))
            .then((response) => (resp = response));
        return resp;
    },
    stationTimetableGET: async (stationId) => {
        let resp;
        await fetch(BackConstants.API_URL_RIDE_HISTORY, {
            method: 'GET',
            mode: 'cors',
            credentials: 'include'
        })
            .then((response) => (response = response.json()))
            .then((response) => (resp = response));
        return resp;
    }
};
export default endpointService;
