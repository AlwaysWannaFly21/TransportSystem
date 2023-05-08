import React, { useState, useEffect } from "react";

function CurrentTime() {
  const [currentTime, setCurrentTime] = useState("");

  useEffect(() => {
    const interval = setInterval(() => {
      const time = new Date();
      const hours = time.getHours();
      const minutes = time.getMinutes().toString().padStart(2, '0'); // add leading zero to minutes
      const seconds = time.getSeconds().toString().padStart(2, '0'); // add leading zero to seconds
      const formattedTime = `${hours}:${minutes}:${seconds}`;
      setCurrentTime(formattedTime);
    }, 1000);
    return () => clearInterval(interval);
  }, []);

  return <p>{currentTime}</p>;
}

export default CurrentTime;