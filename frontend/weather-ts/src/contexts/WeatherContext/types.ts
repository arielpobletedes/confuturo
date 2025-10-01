import type { WeatherList } from "../../type";

export interface WeatherContextType {
  data: WeatherList;
  setData: React.Dispatch<React.SetStateAction<WeatherList>>;
}
