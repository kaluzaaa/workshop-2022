FROM ubuntu
RUN echo "Buduje sie"
RUN apt update
RUN apt install -y iproute2
ENV workshop_day=1
RUN echo "Test zmiennej workshop_day: ${workshop_day}"
CMD echo "Hello world! Workshop day: ${workshop_day}"