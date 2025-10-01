interface City {
  name: string;
  country: string;
}

interface Temp {
  day: number;
  min: number;
  max: number;
  night: number;
  eve: number;
  morn: number;
}

interface Weather {
  main: string;
  description: string;
  icon: string;
}

export interface WeatherList {
  city: City;
  list: [temp: Temp, weather: Weather[]];
}

export interface Coordinates {
  latitude: number;
  longitude: number;
}
