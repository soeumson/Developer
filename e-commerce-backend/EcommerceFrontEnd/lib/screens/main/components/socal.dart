import 'package:flutter/material.dart';
import 'package:flutter_svg/flutter_svg.dart';
import 'package:news/screens/home/components/search.dart';

import '../../../constants.dart';
import '../../../responsive.dart';

class Socal extends StatelessWidget {
  const Socal({
    Key key,
  }) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Row(
      children: [
        if (!Responsive.isMobile(context)) Search(),
        if (!Responsive.isMobile(context))
          IconButton(
              onPressed: null,
              icon: Icon(
                Icons.person_outline_sharp,
                color: Colors.white,
              )),
        if (!Responsive.isMobile(context))
          Padding(
            padding:
                const EdgeInsets.symmetric(horizontal: kDefaultPadding / 2),
            child: IconButton(
                onPressed: null,
                icon: Icon(
                  Icons.favorite_border_sharp,
                  color: Colors.white,
                )),
          ),
        if (!Responsive.isMobile(context))
          Padding(
            padding:
                const EdgeInsets.symmetric(horizontal: kDefaultPadding / 2),
            child: IconButton(
                onPressed: null,
                icon: Icon(
                  Icons.storefront_sharp,
                  color: Colors.white,
                )),
          ),
        SizedBox(width: kDefaultPadding),
      ],
    );
  }
}
