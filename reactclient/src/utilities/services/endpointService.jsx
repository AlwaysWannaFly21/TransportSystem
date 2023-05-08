import BackConstants from '../pathConstants/backendConstants';
import getCookie from '../../helpers/cookieHelper';

const endpointService = {
    rideRegisterGET: async (stationId) => {
        let resp;
        await fetch(BackConstants.API_URL_RIDE_REGISTER + `?transportUnitId=${stationId}`, {
            method: 'GET',
            mode: 'cors',
            credentials: 'include',
            headers: {
                'Authorization': `bearer ${getCookie('jwtToken')}`                
            }
        })
            .then((response) => (response = response.json()))
            .then((response) => (resp = response));
            console.log(resp)
        return resp;
    },
    userTicketHistoryGET: async () => {
        let resp;
        await fetch(BackConstants.API_URL_RIDE_HISTORY, {
            method: 'GET',
            mode: 'cors',
            credentials: 'include',
            headers: {
                'Authorization': `bearer ${getCookie('jwtToken')}`                
            }
        })
            .then((response) => (response = response.json()))
            .then((response) => (resp = response));
            console.log(resp)
        return resp;
    },
    stationTimetableGET: async (stationId) => {
        let resp;
        await fetch(BackConstants.API_URL_STATION_TIMETABLE + '?stationId=' + stationId, {
            method: 'GET',
            mode: 'cors',
            credentials: 'include'
        })
            .then((response) => (response = response.json()))
            .then((response) => (resp = response));
            console.log(resp)
        return resp;
    },
    timeSeriesGET: async (transportUnitId) => {
        let resp;
        await fetch(BackConstants.API_URL_GET_TIME_SERIES + '?transportUnitId=' + transportUnitId, {
            method: 'GET',
            mode: 'cors',
            credentials: 'include',
            headers: {
                'Authorization': `bearer ${getCookie('jwtToken')}`                
            }
        })
            .then((response) => (response = response.json()))
            .then((response) => (resp = response));
            console.log(resp)
        return resp;
    },
    passangersCountGET: async (transportUnitId) => {
        let resp;
        await fetch(BackConstants.API_URL_GET_PASSENGERS_COUNT + '?transportUnitId=' + transportUnitId, {
            method: 'GET',
            mode: 'cors',
            credentials: 'include',
            headers: {
                'Authorization': `bearer ${getCookie('jwtToken')}`                
            }
        })
            .then((response) => (response = response.json()))
            .then((response) => (resp = response));
            console.log(resp)
        return resp;
    },
    humanListGET: async (transportUnitId) => {
        let resp;
        await fetch(BackConstants.API_URL_GET_HUMAN_LIST + '?transportUnitId=' + transportUnitId, {
            method: 'GET',
            mode: 'cors',
            credentials: 'include',
            headers: {
                'Authorization': `bearer ${getCookie('jwtToken')}`                
            }
        })
            .then((response) => (response = response.json()))
            .then((response) => (resp = response));
            console.log(resp)
        return resp;
    }
};
export default endpointService;
