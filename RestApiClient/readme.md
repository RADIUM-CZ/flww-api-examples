# Ukázka připojení na REST API #

* ukázková aplikace v NET Core využívající RestSharp Nuget pro načtení dat z REST API


### Ukazuje také pouziti ###
* appsetting json konfigurace
* dependency injection (ctor injection)
* logovani

### Použité Nuget balíčky ###
* Microsoft.Extensions.Configuration.EnvironmentVariables
  * umožňuje nahradit konfiguraci z JSON souboru proměnými prostředí - využitelné hlavně při běhu v Dockeru
  * jednotlivé úrovně se oddělují znakem `:` 

* Microsoft.Extensions.Configuration.Json
  * konfigurace v JSON souboru - primární úložiště konfigurace

* Microsoft.Extensions.DependencyInjection
  * DI, kompletní konfigurace v Bootrapeer souboru

* Microsoft.Extensions.Logging.Console
  * Logovani do Console (std out), v dockeru vidět v logu kontejneru