FROM ubuntu
ARG demo=defaultValue
ARG GIT_SHA
RUN echo "Buduje sie"
RUN apt update
RUN apt install -y iproute2
ENV workshop_day=1
ENV GIT_SHA=${GIT_SHA}
RUN echo "Test zmiennej workshop_day: ${workshop_day}, demo: ${demo}, GIT_SHA: ${GIT_SHA}"
CMD echo "Hello world! Workshop day: ${workshop_day}" && printenv