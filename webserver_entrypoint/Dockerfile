#Definindo um entrypoint para o container
FROM ubuntu:18.04
RUN apt-get update && apt-get install -y apache2
EXPOSE 80
CMD ["-D", "FOREGROUND"]
ENTRYPOINT ["apache2ctl"]
