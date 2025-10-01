import React, { useState, useEffect } from "react";
import { type WeatherList } from "../type";
import axios from "axios";

export function useFetch(url: string) {
  const [data, setData] = useState<WeatherList | null>(null);
  const [error, setError] = useState<string | null>(null);

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

  return data;
}
