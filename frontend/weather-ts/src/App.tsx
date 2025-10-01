import { Detail } from "./components/Detail";
import { Footer } from "./components/Footer";
import { Header } from "./components/Header";
import { Copyright } from "./components/Copyright";
import WeatherContextProvider from "./contexts/WeatherContext/WeatherContextProvider";

const App: React.FC = () => {
  return (
    <>
      <div className="todoapp">
        <Header />
        <WeatherContextProvider>
          <Detail />
        </WeatherContextProvider>
        <Footer />
        <Copyright />
      </div>
    </>
  );
};

export default App;
