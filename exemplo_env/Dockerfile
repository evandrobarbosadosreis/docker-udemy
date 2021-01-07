# Executando comando shell com valores das variáveis
FROM ubuntu:18.04
RUN apt-get update && apt-get install -y iputils-ping
ENV var1=ping var2=8.8.8.8
CMD $var1 $var2
