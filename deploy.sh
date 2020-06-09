docker build -t rusdr C:/repos/RusDR/bin/Release/netcoreapp3.1/publish
docker tag rusdr registry.heroku.com/rusdr/web
docker push registry.heroku.com/rusdr/web
heroku container:release web --app rusdr