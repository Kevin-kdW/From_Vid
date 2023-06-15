
import {Heading, VStack} from '@chakra-ui/react'

export const Projects = () => {


  return (
    <div>
      <Heading textAlign={'center'}>Projects</Heading>
      <VStack>
        {projects.map(project)}
      </VStack>
      </div>
  )
}
