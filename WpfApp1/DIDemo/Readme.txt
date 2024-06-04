-> Add Nuget Packages 
	- Microsoft.extensions.hosting
	- serilog.extensions.hosting (alternative to native logging system in .net core)
	- serilog.settings.configuration (Logging configurations can be setup in appSettings.json instead of Hardcoding)
	- serilog.sinks.console (Where we are goign to send our logs to)
	- DI (built in) but AutoFac can also be used.

-> Before we start anything we have to start Logging, so we have to hook it up with Appsettings.json right away.

	 