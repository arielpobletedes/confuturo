import { useContext } from "react";
import WeatherContext from "../contexts/WeatherContext/index";
import { type WeatherContextType } from "../contexts/WeatherContext/types";

export const useWeatherContext = (): WeatherContextType => {
  const context = useContext(WeatherContext);
  if (context === undefined) {
    throw new Error("useMyContext es necesario en WeatherContextProvider");
  }
  return context;
};
