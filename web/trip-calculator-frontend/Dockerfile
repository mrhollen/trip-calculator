FROM ubuntu:18.04

RUN apt update
RUN apt install -y curl

RUN curl -sL https://deb.nodesource.com/setup_10.x | bash -

RUN apt install -y nodejs

RUN npm install -g @angular/cli

WORKDIR /app
COPY ./ ./

ENTRYPOINT [ "ng", "serve", "--host=0.0.0.0", "--disable-host-check" ]