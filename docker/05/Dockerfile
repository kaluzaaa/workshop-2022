FROM ubuntu
ARG demo=defaultValue
ARG GIT_SHA
RUN echo "Buduje sie"
RUN apt update
RUN apt install -y iproute2 tree
ENV workshop_day=1
ENV GIT_SHA=${GIT_SHA}
RUN echo "Test zmiennej workshop_day: ${workshop_day}, demo: ${demo}, GIT_SHA: ${GIT_SHA}"
COPY app.sh /app/app1/
COPY * /app/app2/
COPY *.sh /app/src/
COPY app.sh /app/app3/demo.sh
COPY app.sh /app/
WORKDIR /app
CMD ./app.sh