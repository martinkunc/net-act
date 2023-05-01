### Example repository for .net framework unit test with local github workflow.

The idea was to have local container to run .net framework tests from a repo.
It uses linux containers and mono with xbuild.

The [act](https://github.com/nektos/act) is an awesome tool for running github workflows locally in containers and this repo is an attempt to use it.

How it works
There are two actions, first builds a docker image with mono installed to allow continuous tests run faster.\
The tests itself are in [main.yaml](.github/workflows/main.yaml) file. It pulls the container with mono, builds the ConsoleApp1 project and runs nunit tests.
 
### Installation of act and Rancher Desktop with powershell
```
winget install nektos.act
winget install -e --id suse.RancherDesktop
Run Rancher Desktop to finish installation:
& "$(USERPROFILE)\AppData\Local\Programs\Rancher Desktop\Rancher Desktop.exe"
```

Because `act` uses docker cli, Rancher should be configured  to run with docker (moby) runtime, and kubernetes services are not required. It is usefull to enable start of Rancher during startup in its preferences.


### building test image and running tests

List available workflows:
```
act -l
```

Build test docker image:
```
act -j 'docker-image-test'
```


Compile solution and run the test
```
act -j 'build'
```

Watch folder for changes and run tests continuously

```
act -w -j 'build' --env LOCAL_RUN=true
```


Result:
<img src='assets/result.png'>
