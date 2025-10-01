import React, { useState, useEffect } from "react";
import { useWeatherContext } from "../hooks/useWeatherContext";
import axios from "axios";

function useWeatherService(url: string) {
  const [error, setError] = useState<string | null>(null);

  const { data, setData } = useWeatherContext();

  useEffect(() => {
    axios
      .get(url)
      .then((response) => {
        setData(response.data);
      })
      .catch((error) => {
        setError(error);
      });
  }, [url]);

  return error;
}

export default useWeatherService;
