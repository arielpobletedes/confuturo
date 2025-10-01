import { createContext } from "react";
import { type WeatherContextType } from "./types";

const WeatherContext = createContext<WeatherContextType | undefined>(undefined);

export default WeatherContext;
