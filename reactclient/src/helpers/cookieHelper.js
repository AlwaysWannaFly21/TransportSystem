export default function getCookie(name) {
    // Split all cookies into an array
    const cookies = document.cookie.split(';');
    
    // Loop through all cookies and check if the cookie name matches
    for (let i = 0; i < cookies.length; i++) {
      const cookie = cookies[i].trim(); // Remove whitespace
      if (cookie.startsWith(`${name}=`)) {
        // If the cookie name matches, return its value
        return cookie.substring(name.length + 1);
      }
    }
    // If the cookie name is not found, return null
    return null;
  }