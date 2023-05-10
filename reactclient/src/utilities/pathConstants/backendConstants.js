const API_BASE_URL_DEVELOPMENT = "http://localhost:5242";

const ENDPOINTS ={
    RIDE_HISTORY: "api/RideHistory",
    STATION:'api/Station',
    RIDE_REGISTER:"api/RideRegister",
    AUTH_USER:"api/Authentication"
}

const development = {
    API_URL_RIDE_HISTORY: `${API_BASE_URL_DEVELOPMENT}/${ENDPOINTS.RIDE_HISTORY}`,
    API_URL_RIDE_REGISTER: `${API_BASE_URL_DEVELOPMENT}/${ENDPOINTS.RIDE_REGISTER}`,
    API_URL_STATION_TIMETABLE: `${API_BASE_URL_DEVELOPMENT}/${ENDPOINTS.STATION}/station`,
    API_URL_GET_PASSENGERS_COUNT: `${API_BASE_URL_DEVELOPMENT}/${ENDPOINTS.RIDE_REGISTER}/GetPassengersCount`,
    API_URL_GET_TIME_SERIES: `${API_BASE_URL_DEVELOPMENT}/${ENDPOINTS.RIDE_REGISTER}/GetTimeSeries`,
    API_URL_GET_HUMAN_LIST: `${API_BASE_URL_DEVELOPMENT}/${ENDPOINTS.RIDE_REGISTER}/GetHumanList`,
    API_REGISTER_USER:`${API_BASE_URL_DEVELOPMENT}/${ENDPOINTS.AUTH_USER}/register`,
    API_LOGIN_USER:`${API_BASE_URL_DEVELOPMENT}/${ENDPOINTS.AUTH_USER}/login`,
}

export default development;