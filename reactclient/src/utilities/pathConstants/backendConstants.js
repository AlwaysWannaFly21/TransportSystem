const API_BASE_URL_DEVELOPMENT = "http://localhost:5242";

const ENDPOINTS ={
    RIDE_HISTORY: "api/RideHistory",
    STATION:'api/Station'
}

const development = {
    API_URL_RIDE_HISTORY: `${API_BASE_URL_DEVELOPMENT}/${ENDPOINTS.RIDE_HISTORY}`,
    API_URL_STATION_TIMETABLE: `${API_BASE_URL_DEVELOPMENT}/${ENDPOINTS.STATION}/station`,
}

export default development;