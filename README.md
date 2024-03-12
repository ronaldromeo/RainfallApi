# RainfallApi
Operations relating to rainfall
- This is a test project to get the rainfall data. 
- There are no dependencies except than to run this, the machine must be connected to the internet as it is using a 3rd party test api from Department of Environment Food & Rural Affairs in UK
- Instructions to run:
  1. Download the Rainfall.zip. Extract it on your local machine.
  2. Open the RainfallApi solution (RainfallApi.sln) in Visual Studio. Build it. Run it.
  3. In the swagger expand the node Stations GET.
  4. Click Try it out then enter a valid stationId: 3680, the count is optional. If you don't enter anything it will default to 10.
  5. You should be getting a response Ok (200) and the list of the data.
- Instructions to test:
  1. From visual studio (ide) click on Test then Test Explorer.

  ![Uploading image.png…]()
  1. You should be seeing that in the test explorer.
  2. Click on the yellow > button to run the test.
  
  
